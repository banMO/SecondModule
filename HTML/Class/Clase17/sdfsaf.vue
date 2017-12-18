<template>
  <div>
    <nav class="navbar"></nav>
      <div class="container">
        <div class="login">
            <h1>{{msg}}</h1>
            <button class="google-login"><i class="fa fa-google-plus" aria-hidden="true"></i>Sign in with Google</button>
        </div>
      </div>       
  </div>
</template>

<script>
export default {
  name: 'HelloWorld',
  data () {
    return {
      msg: 'Welcome to Your Vue.js App'
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.navbar {
  height: 50px;
  background: rgb(106, 56, 42);
}

.container {
  height: 100%;
  width: 100%;
  background-image: url(../assets/ini.jpg);
  background-repeat: none;
  background-size: 100%;
  float: left;
  overflow-y: auto; 
  overflow-x: hidden;

}

.login{
    margin-top: 50px;
    margin-right: 70%;
    background-color: rgba(255, 255, 255, 0.8);
    border-radius: 10px;
    margin-left: 10%;  
    height:  30%;
}

.google-login{
    height: 50px;
    width: 200px;
    background-color: #DC3C32;
    color: white;
    font-size: 14px;
    border-radius: 10px;
    font-style: normal;
    margin-top: 40px;
    margin-left: 20px;
}
</style>