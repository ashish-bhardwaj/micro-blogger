import React, { Component } from 'react';
import Home from './client/home.js';
import BlogPost from './client/blogpost.js';
import './App.css';
import { Tab, Tabs, TabList, TabPanel } from 'react-tabs';
import 'react-tabs/style/react-tabs.css';

class App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      blogs: []
    };
    this.blogAdded = this.blogAdded.bind(this);
  }

  componentDidMount(){
    this.setState({
      blogs: [
        { blog: "A bfbk djknfjdbf", title: "A" },
        { blog: "B bfbk djknfjdbf", title: "B" }
      ]
  });
  }

  blogAdded(e, blog) {
    e.preventDefault();
    console.log(blog.title);
    console.log(blog.blog);
    
    this.setState( (prev) => ({
      blogs: prev.blogs.concat(blog)
    }));
  }

  render() {
    return (
      <Tabs>
        <TabList>
          <Tab>Home</Tab>
          <Tab>Blog post</Tab>
        </TabList>

        <TabPanel>
          <Home blogs={this.state.blogs}/>
        </TabPanel>
        <TabPanel>
          <BlogPost onSave={this.blogAdded}/>
        </TabPanel>
      </Tabs>

    );
  }
}

export default App;
