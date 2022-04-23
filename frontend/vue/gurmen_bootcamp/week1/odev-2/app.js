const app = Vue.createApp({
  data() {
    return {
      value: '',
    }
  },

  methods: {
    showAlert() {
      alert('hata meydana geldi')
    },
    addValue(e) {
      console.log('çalıştı')
      this.value = e.target.value
      e.target.value = ''
    },
    addValueEnter(e) {
      this.value = e.target.value
      e.target.value = ''
    },
  },
})
app.mount('#exercise')
