# PersonaMicroService
Microserviços de Persona para consultar as respostas de classe dos dias de aula dos jogos Persona 3 Reload, Persona 4 Golden e Persona 5 Royal
# Persona 3 Reload
- 100% concluído, deploy: https://persona3.onrender.com
- Modo de uso: endpoint https://persona3.onrender.com/class/p3r/{mes}/{dia}; Exemplo-GET: https://persona3.onrender.com/class/p3r/october/30
- Exemplo do retorno:
```
{
    "question": "“A certain enzyme brings out the sweetness in them when they’re baked. Do you happen to know what it is?”",
    "answer": "“Beta-amylase.” (#1)",
    "error": null
}
```

# Persona 4 Golden
- 100% concluído
- Modo de uso: endpoint /class/p4g/{mes}/{dia}; Exemplo-GET: /class/p4g/april/18
- Exemplo do retorno:
```
{
    "question": "“The word ‘alphabet’ comes from the word ‘alpha’ and what other one?”",
    "answer": "“Beta.” (#3)",
    "error": null
}
```

# Persona 5 Royal
- 100% concluído
- Modo de uso: endpoint /class/p5r/{mes}/{dia}; Exemplo-GET: /class/p5r/october/22
- Exemplo do retorno:
```
{
    "question": "“Now, tell me the total count for each column in this magic square.”",
    "answer": "“15.”",
    "error": null
}
```
