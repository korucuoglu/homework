import { createStore } from 'vuex'

const store = createStore({
  state: {
    cupon: {
      betAmount: 5,
      matches: [],
    },
  },

  getters: {
    _cupon: (state) => state.cupon,
    _matches: (state) => state.cupon.matches,
    _betAmount: (state) => state.cupon.betAmount,
  },

  mutations: {
    addMatchtoCupon(state, item) {
      if (state.cupon.matches.some((x) => x.matchId === item.matchId)) {
        var result = state.cupon.matches.find((x) => x.matchId === item.matchId)
        result.bet = item.bet
        result.rate = item.rate
        return
      }
      state.cupon.matches.push(item)
    },
    changeBetAmount(state, item) {
      state.cupon.betAmount = item
    },
  },
})

export default store
