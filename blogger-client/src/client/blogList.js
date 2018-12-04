import React, { Component } from 'react';
import { Query } from "react-apollo";
import gql from "graphql-tag";
import Blog from './blog.js';

const GET_BLOGS = gql`
  {
    blogs {
      id
      blogContent
      blogTitle
    }
  }
`;

class BlogList extends Component {
  constructor(props) {
    super(props);
  }
  
  render() {
    return (
      <Query query={GET_BLOGS}>
        {({ loading, error, data }) => {
          if (loading) return <div>Fetching</div>
          if (error) return <div>Error</div>

          const blogsToRender = data.blogs

          return (
            <div>
              {blogsToRender.map(blog => <Blog key={blog.id} data={blog} />)}
            </div>
          )
        }}
      </Query>
    )
  }
}
export default BlogList;
