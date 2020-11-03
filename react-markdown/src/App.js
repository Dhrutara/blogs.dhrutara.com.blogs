import './App.css';
import ImageRenderer from '../src/components/image-renderer';
import HeaderRenderer from '../src/components/header-renderer';
import ReactMarkdown from 'react-markdown';

const MarkDown = `> Sample markdown that will be rendered as html 
# Header1
## Header2
### Header3
#### Header4
##### Header5
###### Header6


> This image will be rendered as html element figure with figurecaption.
![A sample image](/images/Screenshot.jpg) 


> Complete`;

function App() {
  return (
    <div className="App">
      <div>
        <ReactMarkdown source={MarkDown} escapeHtml={false} renderers={{ "image": ImageRenderer, "heading": HeaderRenderer}} />
      </div>
    </div>
  );
}

export default App;
