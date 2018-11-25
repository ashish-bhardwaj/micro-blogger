import React, { Component } from 'react';


class Home extends Component {
    render() {
        
        const t = this.props.blogs.map((blog) => 
            <div key={blog.title}>
                Title:{blog.title}<br/>
            </div>
        );
        return t;
    }
}

export default Home;

