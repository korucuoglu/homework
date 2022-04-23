Vue.createApp({
  data() {
    return {
      name: 'Abdullah Halit Korucuoğlu',
      age: 25,
      imageUri: 'https://via.placeholder.com/500x500',
    }
  },

  methods: {
    getRandom() {
      return Math.floor(Math.random() * 1000)
    },
  },
}).mount('#app')
