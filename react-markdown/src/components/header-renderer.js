export default function HeaderRenderer(props) {
    switch (props.level) {
        case 1:
            return (<div style={{ "backgroundColor": "violet", "fontSize": "60px", "display": "table" }}>{props.children}</div>);
        case 2:
            return (<div style={{ "backgroundColor": "blue", "fontSize": "50px", "display": "table" }}>{props.children}</div>);
        case 3:
            return (<div style={{ "backgroundColor": "green", "fontSize": "40px", "display": "table" }}>{props.children}</div>);
        case 4:
            return (<div style={{ "backgroundColor": "orange", "fontSize": "30px", "display": "table" }}>{props.children}</div>);
        case 5:
            return (<div style={{ "backgroundColor": "yellow", "fontSize": "20px", "display": "table" }}>{props.children}</div>);
        case 6:
        default:
            return (<div style={{ "backgroundColor": "red", "fontSize": "10px", "display": "table" }}>{props.children}</div>);
    }
}