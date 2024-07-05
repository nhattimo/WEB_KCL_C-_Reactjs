import React, { useState } from 'react';
import { Container, Row, Col, Nav, Navbar, Button, NavItem } from 'react-bootstrap';
import 'bootstrap/dist/css/bootstrap.min.css';
import './layout.css';
import a1 from '../../public/image/adminlogo.jpg'
const AdminLayout = ({ children }) => {
  const [sidebarOpen, setSidebarOpen] = useState(false);

  const handleSidebarToggle = () => {
    setSidebarOpen(!sidebarOpen);
  };

  return (
    <div className="admin-layout">
      <Container fluid className='adminnav'>
        <Row>
          <Col xs={sidebarOpen ? 2 : 1} id="sidebar-wrapper" className={sidebarOpen ? 'sidebar-open' : 'sidebar-closed'}>
            <Nav className="flex-column">
            <Nav.Item className='logo'>
                <Nav.Link href="#">
                  <img src={a1} alt="Admin logo" />
                </Nav.Link>
              </Nav.Item>
              <Nav.Item>
                <Nav.Link href="#">Home</Nav.Link>
              </Nav.Item>
              <Nav.Item>
                <Nav.Link href="#">About</Nav.Link>
              </Nav.Item>
              <Nav.Item>
                <Nav.Link href="#">Pages</Nav.Link>
              </Nav.Item>
              <Nav.Item>
                <Nav.Link href="#">Portfolio</Nav.Link>
              </Nav.Item>
              <Nav.Item>
                <Nav.Link href="#">Contact</Nav.Link>
              </Nav.Item>
            </Nav>
          </Col>
          <Col xs={sidebarOpen ? 10 : 11} id="page-content-wrapper">
            <Navbar bg="light" expand="lg">
              <Button   variant="primary" onClick={handleSidebarToggle}>
                <i className={sidebarOpen ? 'fa-solid fa-angles-left' : 'fa fa-bars'} ></i>
              </Button>
              <Navbar.Toggle aria-controls="basic-navbar-nav" />
              <Navbar.Collapse id="basic-navbar-nav">
                <Nav className="ml-auto">
                  <Nav.Item>
                    <Nav.Link href="#">Home</Nav.Link>
                  </Nav.Item>
                  <Nav.Item>
                    <Nav.Link href="#">About</Nav.Link>
                  </Nav.Item>
                  <Nav.Item>
                    <Nav.Link href="#">Portfolio</Nav.Link>
                  </Nav.Item>
                  <Nav.Item>
                    <Nav.Link href="#">Contact</Nav.Link>
                  </Nav.Item>
                </Nav>
              </Navbar.Collapse>
            </Navbar>
            <Container fluid>
              <h2 className="mb-4">Sidebar #01</h2>
              {children}
            </Container>
          </Col>
        </Row>
      </Container>
    </div>
  );
};

export default AdminLayout;
