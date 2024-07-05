import React, { useCallback, useState } from 'react';
import AppBar from '@mui/material/AppBar';
import Avatar from '@mui/material/Avatar';
import Grid from '@mui/material/Grid';
import IconButton from '@mui/material/IconButton';
import MenuIcon from '@mui/icons-material/Menu';
import Tab from '@mui/material/Tab';
import Tabs from '@mui/material/Tabs';
import Toolbar from '@mui/material/Toolbar';
import Typography from '@mui/material/Typography';
import { useRouter } from 'next/router';
import { Menu, MenuItem } from '@mui/material';
import { signOut, useSession } from 'next-auth/react';

function AdminHeader({ onDrawerToggle }) {
  const router = useRouter();
  const session = useSession();

  const onChangeTab = useCallback((url) => {
    router.push(url).then();
  }, [router]);

  return (
    <React.Fragment>
      <AppBar color="primary" position="sticky" elevation={0}>
        <Toolbar>
          <Grid container spacing={1} alignItems="center">
            <Grid sx={{ display: { sm: 'none', xs: 'block' } }} item>
              <IconButton
                color="inherit"
                aria-label="open drawer"
                onClick={onDrawerToggle}
                edge="start"
              >
                <MenuIcon />
              </IconButton>
            </Grid>
            <Grid item xs />
            <Grid item>
              Welcome, {session.data?.user?.name}
              <UserMenu />
            </Grid>
          </Grid>
        </Toolbar>
      </AppBar>
      <AppBar
        component="div"
        color="primary"
        position="static"
        elevation={0}
        sx={{ zIndex: 0 }}
      >
        <Toolbar>
          <Grid container alignItems="center" spacing={1}>
            <Grid item xs>
              <Typography color="inherit" variant="h5" component="h1">
                {getHeaderTitle(router.pathname)}
              </Typography>
            </Grid>
          </Grid>
        </Toolbar>
      </AppBar>
      <AppBar
        component="div"
        position="static"
        elevation={0}
        sx={{ zIndex: 0 }}
      >
        <Tabs
          value={router.pathname.includes('create') ? 0 : 1}
          textColor="inherit"
        >
          <Tab
            label="Create"
            onClick={() =>
              onChangeTab(`${getHeaderBasePath(router.pathname)}/create`)
            }
          />
          <Tab
            label="Browse"
            onClick={() =>
              onChangeTab(`${getHeaderBasePath(router.pathname)}/`)
            }
          />
        </Tabs>
      </AppBar>
    </React.Fragment>
  );
}

function UserMenu() {
  const [anchorEl, setAnchorEl] = useState(null);
  const open = Boolean(anchorEl);
  const handleClick = (event) => {
    setAnchorEl(event.currentTarget);
  };
  const onLogoutClick = () => {
    setAnchorEl(null);
    signOut().then();
  };

  const handleClose = () => {
    setAnchorEl(null);
  };

  return (
    <>
      <IconButton
        color="inherit"
        sx={{ p: 0.5 }}
        id="demo-positioned-button"
        aria-controls={open ? 'demo-positioned-menu' : undefined}
        aria-haspopup="true"
        aria-expanded={open ? 'true' : undefined}
        onClick={handleClick}
      >
        <Avatar alt="My Avatar" />
      </IconButton>
      <Menu
        id="demo-positioned-menu"
        aria-labelledby="demo-positioned-button"
        anchorEl={anchorEl}
        open={open}
        onClose={handleClose}
        anchorOrigin={{
          vertical: 'top',
          horizontal: 'left',
        }}
        transformOrigin={{
          vertical: 'top',
          horizontal: 'left',
        }}
      >
        <MenuItem onClick={onLogoutClick}>Log out</MenuItem>
      </Menu>
    </>
  );
}

export default AdminHeader;

function getHeaderTitle(pathname) {
  // Define your logic to get the header title based on the pathname
  return "Header Title"; // Example static return value
}

function getHeaderBasePath(pathname) {
  // Define your logic to get the base path for header tabs based on the pathname
  return "/base-path"; // Example static return value
}
