import axios from 'axios';
import React, { FormEvent, useState } from 'react';
import { Button, Col, Form, FormGroup, Input, Label, Row } from 'reactstrap';
import Author, { authorDetails } from '../components/Author';

export default function Home() {
    const [version, setVersion] = useState<string>('');
    const [authors, setAuthors] = useState<authorDetails[]>([new authorDetails(null, null), new authorDetails(null, null)]);
    const [selectedFile, setSelectedFile] = useState<File>();

    const handleFileSelectionChanged = (e: any) => {
        if (e.target.files && e.target.files.length > 0) {
            setSelectedFile(e.target.files[0]);
        }
    }

    const handleFormSubmit = (e: FormEvent<HTMLFormElement>) => {
        e.preventDefault();

        const formData = new FormData();
        formData.append('version', version);
	formData.append('file', selectedFile as Blob, selectedFile?.name);
	    
        let index = 0;
        authors?.forEach(element => {
            if (element) {
                formData.append(`authors[${index}].firstName`, element.firstName || '');
                formData.append(`authors[${index}].lastName`, element.lastName || '');
                index++;
            }
        });

        axios({
            method: 'POST',
            data: formData,
            url: "api/document/uploaddocument",
            headers: {
                'Content-Type': 'multipart/form-data',
            }
        })
            .then(() => {
                alert('Document added succesfully');
            })
            .catch((err) => {
                const errorMessage = typeof err.response.data === 'string' ? err.response.data : err.response.data.title;
                alert(errorMessage);
            });

    }

    function handleAuthorChange(index:number, authorData: authorDetails) {
        if (authorData) {
            const localAuthors = [...authors];
            localAuthors[index] = authorData;
            setAuthors(localAuthors);
        }
    }

    return (
        <React.Fragment>
            <Row>
                <h2>Add Documents</h2>
            </Row>

            <Form onSubmit={handleFormSubmit}>
                <Row>
                    <Col xs={12} sm={12} md={12} lg={12} xl={12}>
                        <FormGroup>
                            <Label for="version">Document Version</Label>
                            <Input type="text" required={true} name="version" id="version" value={version} onChange={(evt) => setVersion(evt.target.value)} />
                        </FormGroup>
                    </Col>
                </Row>
                {
					authors && <div><p></p><h4>Authors' Details</h4></div>
				}
				{
					authors && authors.map((s, index) => <Author key={index} props={{ index: index, data: s, changeHandler: handleAuthorChange }} />)
				}
                <Row>
                    <Col xs={12} sm={12} md={12} lg={12} xl={12}>
                        <h4>Document to Add</h4>
                    </Col>
                    <Col xs={12} sm={12} md={12} lg={12} xl={12}>
                        <input type="file" style={{ "overflow": "hidden", "width": "100%" }} onChange={handleFileSelectionChanged} />
                    </Col>
                </Row>
                <Row>
                    <Col xs={12} sm={12} md={12} lg={12} xl={12}>
                        <p></p>
                    </Col>
                    <Col xs={12} sm={12} md={12} lg={12} xl={12}>
                        {
                            selectedFile && <Button type="submit" color="primary" style={{ "width": "100%" }}>Add Document</Button>
                        }
                    </Col>
                </Row>
            </Form>
        </React.Fragment>
    );
}
