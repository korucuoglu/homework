<template>
  <header>Comment Like/Dislike App</header>
  <div class="container">
    <div class="comment--like--dislike--app">
      <div
        class="card mb-10 comment--item"
        v-for="comment in comments"
        :key="comment"
      >
        <p>
          {{ comment.text }}
        </p>
        <div class="action--button--container text-right mt-10">
          <button class="btn-sm btn-success" @click="comment.like++">
            Beğendim ({{ comment.like }})
          </button>
          <button class="btn-sm btn-danger" @click="comment.dislike++">
            Beğenmedim ({{ comment.dislike }})
          </button>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
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
