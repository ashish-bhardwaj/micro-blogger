import React, { Component } from 'react'

class Blog extends Component {
  render() {
    return (      
      <div class="bb b--black-05 background-gray pa4 ">
        <h4 class="mt4 fw6 f6">{this.props.data.blogTitle}</h4>
        <div>
          <p class="measure-wide lh-copy">
            {this.props.data.blogContent}
          </p>
        </div>
      </div>
    )
  }
}

export default Blog