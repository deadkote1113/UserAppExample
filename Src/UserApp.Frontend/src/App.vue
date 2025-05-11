<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
import IconHome from './components/icons/IconHome.vue';
import IconProfile from './components/icons/IconProfile.vue';
import IconUsers from './components/icons/IconUsers.vue';
</script>

<template>
  <div class="wrapper">
    <section class="navigation">
      <div class="company sideBarElem">
        <img src="./assets/Subtract.svg" alt="">
        <p>User App</p>
      </div>
      <ul class="menu">
        <li class="menuItem sideBarElem sideBarElem--selected">
          <RouterLink to="/" class="menuItemText">
            <IconHome />
            <p>Home</p>
          </RouterLink>
        </li>
        <li class="menuItem sideBarElem">
          <RouterLink to="/profile" class="menuItemText">
            <IconProfile />
            <p>Profile</p>
          </RouterLink>
        </li>
        <li class="menuItem sideBarElem">
          <RouterLink to="/users" class="menuItemText">
            <IconUsers />
            <p>Users</p>
          </RouterLink>
        </li>
      </ul>
    </section>
    <RouterView />
  </div>
</template>

<style scoped></style>
