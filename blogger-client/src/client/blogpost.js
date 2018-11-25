import React, { Component } from 'react';


class BlogPost extends Component {
    constructor(props){
        super(props);
        this.state = {blog:'', title:''}
    }

    onTitleChange(e){
        this.setState({ title: e.target.value });
    }

    onBlogChange(e){
        this.setState({ blog: e.target.value });
    }

    onSubmit(e, value){
        e.preventDefault();
        this.props.onSave(value);
    }

    render() {
        return (
            <form>
                Title: <input id="title" type="text" value={this.state.title} onChange={(e)=>this.onTitleChange(e)}/>
                <br/>
                Post: <input id="post" type="text" value={this.state.blog} onChange={(e)=>this.onBlogChange(e)}/>
                <br/>
                <button>Save</button>
                <button type="Submit" onClick={(e) => this.props.onSave(e, this.state)}>Submit</button>
            </form>
        );
    }
}

export default BlogPost;

