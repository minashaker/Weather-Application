/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        './Pages/**/*.cshtml',
        './Views/**/*.cshtml',
        './Views/Shared/**/*.cshtml',
        './wwwroot/js/**/*.js'
    ],
    theme: {
      
        extend: {
            screens: {
                xs : "320px",
                sm: "576px",
                md: "768px",
                lg: "992px",
                xl: "1200px",
            },
            colors: {
                
            }
        },
  },
  plugins: [],
}

