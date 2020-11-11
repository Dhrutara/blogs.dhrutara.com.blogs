import React, { ChangeEvent } from 'react';
import { Row, Col, FormGroup, Label, Input } from 'reactstrap';

export class authorDetails {
    firstName: string | null;
    lastName: string | null;

    constructor(firstName: string | null, lastName: string | null) {
        this.firstName = firstName;
        this.lastName = lastName;
    }
}

export interface iAuthorDetails {
    index: number,
    data: authorDetails,
    changeHandler: ( id:number, data: authorDetails) => void
}

export default function Author({ props }: { props: iAuthorDetails }) {

    const handleChange = (evt: ChangeEvent<HTMLInputElement>) => {
        const value = evt.target.type === "checkbox" ? evt.target.checked : evt.target.value;
        const newValue = { ...props.data } as any;
        newValue[evt.target.name.toString()] = value as string;
        if (props.changeHandler && typeof props.changeHandler === 'function') {
            props.changeHandler(props.index, newValue as authorDetails);
        }
    }

    return (
        <React.Fragment>
            <Row>
                <Col xs={12} sm={12} md={6} lg={6} xl={6}>
                    <FormGroup>
                        <Label for="firstName">Author First Name</Label>
                        <Input type="text" name="firstName" id="firstName" required={true} value={props.data.firstName || ''} onChange={handleChange} />
                    </FormGroup>
                </Col>
                <Col xs={12} sm={12} md={6} lg={6} xl={6}>
                    <FormGroup>
                        <Label for="lastName">Author Last Name</Label>
                        <Input type="text" name="lastName" id="lastName" required={true} value={props.data.lastName || ''} onChange={handleChange} />
                    </FormGroup>
                </Col>
            </Row>
        </React.Fragment>
    );
}
