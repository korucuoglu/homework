<template>
  <div>
    <header>Class List App</header>
    <div class="container">
      <div class="class--list--app">
        <div class="card">
          <ul class="class-list">
            <li>
              <label>
                <input class="mr-5" type="checkbox" v-model="backgroundColor" />
                <span>Background Color</span>
              </label>
            </li>
            <li>
              <label>
                <input class="mr-5" type="checkbox" v-model="border" />
                <span>Border</span>
              </label>
            </li>
            <li>
              <label>
                <input class="mr-5" type="checkbox" v-model="borderRadius" />
                <span>Border Radius</span>
              </label>
            </li>
            <li>
              <label>
                <input class="mr-5" type="checkbox" v-model="color" />
                <span>Color</span>
              </label>
            </li>
            <li>
              <label>
                <input class="mr-5" type="checkbox" v-model="fontBold" />
                <span>Font Bold</span>
              </label>
            </li>
            <li>
              <label>
                <input class="mr-5" type="checkbox" v-model="fontItalic" />
                <span>Font Italic</span>
              </label>
            </li>
          </ul>
          <textarea :style="getStyle" rows="5">
Lorem ipsum dolor sit amet consectetur adipisicing elit. Corrupti fuga nam earum, pariatur culpa magnam inventore libero alias ut, doloribus aliquam. Eligendi consectetur unde possimus eos placeat odio ex modi!</textarea
          >
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      backgroundColor: false,
      border: false,
      borderRadius: false,
      color: false,
      fontBold: false,
      fontItalic: false,
    }
  },

  computed: {
    getStyle() {
      var style = ''

      style += this.backgroundColor ? 'background-color: #d9cdcd;' : ''
      style += this.color ? 'color:green;' : ''
      style += this.border ? 'border:5px solid black;' : ''
      style += this.fontBold ? 'font-weight:800;' : ''
      style += this.borderRadius ? 'border-radius:25px;' : ''
      style += this.fontItalic ? 'font-style: italic;' : ''

      console.log(style)

      return style
    },
  },
}
</script>
