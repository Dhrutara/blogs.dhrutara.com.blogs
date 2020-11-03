import './App.css';
import ImageRenderer from '../src/components/image-renderer';
import HeaderRenderer from '../src/components/header-renderer';
import CodeRenderer from '../src/components/code-block-renderer';
import ReactMarkdown from 'react-markdown';

const MarkDown = `> Sample markdown that will be rendered as html 

**Sample Headers**
# Header1
## Header2
### Header3
#### Header4
##### Header5
###### Header6


**This image will be rendered as html element figure with figurecaption.**
![A sample image](/images/Screenshot.jpg) 

**Below code will be rendered with line numbers and line highlights**

\`\`\`javascript{1,3,5}
const sampleFunction = () => {

  const value = '1'
  let language = value;
  let lineHighlights = [];
  const obj = { 'language': language, 'lineHighlights': lineHighlights }; 
  return obj
}
\`\`\`

> Complete`;

function App() {
  return (
    <div className="App">
      <div>
        <ReactMarkdown source={MarkDown} escapeHtml={false} renderers={{ "image": ImageRenderer, "heading": HeaderRenderer, "code": CodeRenderer }} />
      </div>
    </div>
  );
}

export default App;
