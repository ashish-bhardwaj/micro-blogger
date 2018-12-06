import React, { Component } from 'react';
import { Mutation } from 'react-apollo'
import gql from 'graphql-tag'

const POST_MUTATION = gql`
  mutation PostMutation($blogTitle: String!, $blogContent: String!) {
    createBlogTest(blogTitle: $blogTitle, blogContent: $blogContent) {
      id
      blogTitle
      blogContent
    }
  }
`

class CreateBlog extends Component {
    constructor(props) {
        super(props);
        this.state = { blogTitle: '', blogContent: '' }
    }

    onTitleChange(e) {
        this.setState({ blogTitle: e.target.value });
    }

    onBlogChange(e) {
        this.setState({ blogContent: e.target.value });
    }

    render() {
        const { blogTitle, blogContent } = this.state
        return (
            <div>
                Title: <input className="flex flex-column mt3" id="title" type="text" value={this.state.blogTitle} onChange={(e) => this.onTitleChange(e)} />
                <br />
                Post: <input id="post" type="text" value={this.state.blogContent} onChange={(e) => this.onBlogChange(e)} />
                <br />

                <Mutation
                    mutation={POST_MUTATION}
                    variables={{ blogTitle, blogContent }}
                    onCompleted={() => this.props.history.push('/')}
                >
                {
                    postMutation => <button onClick={postMutation}>Submit</button>
                }
                </Mutation>
            </div>

        );
    }
}

export default CreateBlog
