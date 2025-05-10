<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
import HelloWorld from './components/HelloWorld.vue'
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
          <a class="menuItemText icon-Home" href=""><p>Home</p></a>
        </li>
        <li class="menuItem sideBarElem">
          <a class="menuItemText icon-Home" href=""><p>Home</p></a>
        </li>
        <li class="menuItem sideBarElem">
          <a class="menuItemText icon-Home" href=""><p>Home</p></a>
        </li>
        <li class="menuItem sideBarElem">
          <a class="menuItemText icon-Home" href=""><p>Home</p></a>
        </li>
      </ul>
    </section>
    <RouterView />
  </div>
</template>

<style scoped>

</style>
