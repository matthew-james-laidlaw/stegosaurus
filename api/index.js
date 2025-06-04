const express = require('express');
const multer = require('multer');
const path = require('path');
const { v4: uuidv4 } = require('uuid');

const app = express();
const upload = multer({ dest: 'uploads/' });

app.get('/movies', (req, res) => {});
app.get('/movies/:id', (req, res) => {});

app.get('/movies/:id/hls/master.m3u8', (req, res) => {});
app.get('/movies/:id/hls/:variant/index.m3u8', (req, res) => {});
app.get('/movies/:id/hls/:variant/:segment', (req, res) => {});

app.post('/movies', (req, res) => {});

app.delete('/movies/:id', (req, res) => {});
