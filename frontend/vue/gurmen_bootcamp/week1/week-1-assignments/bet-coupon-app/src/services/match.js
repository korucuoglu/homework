import { http } from '../utils/http'

const MatchService = {
  async getAll(page) {
    var result = await http.get('data')
    return this.mappingData(result.data.slice((page - 1) * 10, page * 10))
  },
  async getById(id) {
    var match = await (await http.get(`data/${id}`)).data
    return {
      id: match.id,
      home: match.takim1,
      away: match.takim2,
      clock: match.Saat,
      rates: {
        home: (Math.round(match.ms1 * 100) / 100).toFixed(2),
        draw: (Math.round(match.ms0 * 100) / 100).toFixed(2),
        away: (Math.round(match.ms2 * 100) / 100).toFixed(2),
      },
    }
  },

  mappingData(data) {
    return data.map((match) => {
      return {
        id: match.id,
        home: match.takim1,
        away: match.takim2,
        clock: match.Saat,
        rates: {
          home: (Math.round(match.ms1 * 100) / 100).toFixed(2),
          draw: (Math.round(match.ms0 * 100) / 100).toFixed(2),
          away: (Math.round(match.ms2 * 100) / 100).toFixed(2),
        },
      }
    })
  },
}

export default MatchService
