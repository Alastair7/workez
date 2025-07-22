export const getDayName = (date: string, locale: string) => new Date(date).toLocaleDateString(locale, { weekday: "long" }) 
