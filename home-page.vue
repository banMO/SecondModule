<template>
  <div class="container">
    <nav class="navbar"></nav>
    <div class="panel">
      
    </div>
  </div>
</template>

<script>
import Vue from 'vue'
export default {
  data () {
    return {
      dato: this.$route.params.abc
    }
  },
  methods: {
    prube () {
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
/** {
  box-sizing: border-box;
}*/
.container {
  background: #E0E0E0;
  height: 100%;
  width: 100%;
  overflow-x: hidden;
  overflow-y: hidden;
}/*
.navbar{
  height: 50px;
  background: #00766c;
}
.panel {
    margin-top: 10%;
    margin-right: 45%;
    background-color: rgba(106, 56, 42, .3);
    border-radius: 10px;
    margin-left: 8%;
    height:  45%;
}*/
/*home*/
.navbar{
  height: 8%;
  background: #00766c;
}
.panel {
    background-color: #9E9E9E;
    height:  92%;
    width: 70%
}
</style>