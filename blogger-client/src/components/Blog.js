import React, { Component } from 'react'

class Blog extends Component {
  render() {
    return (
      <div className="ba">
        <div >
          {this.props.data.id}: {this.props.data.blogTitle}
        </div>
      </div>
    )
  }
}

export default Blog
