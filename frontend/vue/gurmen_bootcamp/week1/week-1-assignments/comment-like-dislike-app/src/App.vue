<template>
  <header>Comment Like/Dislike App</header>
  <div class="container">
    <CommentList :items="comments" />
  </div>
</template>

<script>
import CommentList from './components/CommentList.vue'
export default {
  components: {
    CommentList,
  },
  data() {
    return {
      comments: [
        {
          text: 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sint',
          like: 10,
          dislike: 5,
        },
        {
          text: 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sint',
          like: 15,
          dislike: 2,
        },
        {
          text: 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sint',
          like: 2,
          dislike: 7,
        },
        {
          text: 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sint',
          like: 7,
          dislike: 6,
        },
      ],
    }
  },
}
</script>
