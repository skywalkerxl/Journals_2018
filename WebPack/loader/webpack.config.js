const HtmlWebpackPlugins = require('html-webpack-plugin');
const path = require('path');

module.exports = {
    entry: './src/app.js',
    output: {
        path: path.resolve(__dirname, 'dist'),
        filename: 'app.js'
    },
    mode: 'development',
    plugins: [
        new HtmlWebpackPlugins({
            filename: 'index.html',
            template: 'src/index.html'
        })
    ]
}