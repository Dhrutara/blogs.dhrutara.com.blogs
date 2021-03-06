﻿import React from 'react';
import { Container, Navbar, NavbarBrand } from 'reactstrap';

export default function NavMenu() {
	return (
		<header>
			<Navbar className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3" light>
				<Container>
					<NavbarBrand>Document Manager</NavbarBrand>
				</Container>
			</Navbar>
		</header>
	);
}
