import React from 'react';
import { Container } from 'reactstrap';
import NavMenu from './NavMenu';

export default function Layout(props: any) {
	return (
		<div>
			<NavMenu/>
			<Container>
				{props.children}
			</Container>
		</div>
	);
}
