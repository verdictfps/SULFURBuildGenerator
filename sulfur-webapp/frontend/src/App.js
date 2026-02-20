import React, {useEffect, useState} from 'react';

function App() {
  const [folders, setFolders] = useState([]);
  const [files, setFiles] = useState([]);
  const [content, setContent] = useState(null);
  const [currentPath, setCurrentPath] = useState('');

  useEffect(() => {
    fetch('/api/list')
      .then(r => r.json())
      .then(setFolders)
      .catch(console.error);
  }, []);

  function loadFolder(path) {
    fetch(`/api/list?path=${encodeURIComponent(path)}`)
      .then(r => r.json())
      .then(items => {
        // distinguish files vs subfolders by presence of ".json" for now
        const onlyFiles = items.filter(i => i.toLowerCase().endsWith('.json'));
        const onlyFolders = items.filter(i => !i.toLowerCase().endsWith('.json'));
        setFiles(onlyFiles.map(f => ({name: f, path: path ? `${path}/${f}` : f})));
        setFolders(onlyFolders.map(f => ({name: f, path: path ? `${path}/${f}` : f})));
        setContent(null);
        setCurrentPath(path || '');
      })
      .catch(console.error);
  }

  function loadFile(path) {
    fetch(`/api/file?path=${encodeURIComponent(path)}`)
      .then(r => r.text())
      .then(setContent)
      .catch(err => setContent('Error loading file: ' + err));
  }

  return (
    <div style={{padding:20}}>
      <h1>SULFUR Web</h1>
      <div style={{display:'flex',gap:20}}>
        <div style={{width:240}}>
          <h3>Top-level</h3>
          <ul>
            <li><button onClick={() => loadFolder('Oils')}>Oils</button></li>
            <li><button onClick={() => loadFolder('Weapons')}>Weapons</button></li>
            <li><button onClick={() => loadFolder('Attachments')}>Attachments</button></li>
            <li><button onClick={() => loadFolder('Scrolls')}>Scrolls</button></li>
          </ul>
          {folders.length>0 && (
            <div>
              <h4>Subfolders</h4>
              <ul>
                {folders.map((f,i)=>(<li key={i}><button onClick={()=>loadFolder(f.path)}>{f.name}</button></li>))}
              </ul>
            </div>
          )}
        </div>

        <div style={{flex:1}}>
          <h3>Files {currentPath?`in ${currentPath}`:''}</h3>
          <ul>
            {files.map((f,i)=>(<li key={i}><button onClick={() => loadFile(f.path)}>{f.name}</button></li>))}
          </ul>
        </div>

        <div style={{flex:2,background:'#f9f9f9',padding:10,border:'1px solid #ddd'}}>
          <h3>Content</h3>
          <pre style={{whiteSpace:'pre-wrap',fontSize:12}}>{content || 'Select a file to view its JSON content'}</pre>
        </div>
      </div>
    </div>
  );
}

export default App;
