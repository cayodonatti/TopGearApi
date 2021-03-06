# TopGear - Aluguel de Veículos
[![Build status](https://ci.appveyor.com/api/projects/status/7fmtvv4c64t0fngl/branch/master?svg=true&passingText=master%20-%20OK&failingText=master%20-%20FAIL)](https://ci.appveyor.com/project/cayodonatti/topgearapi)
[![Quality Gate](https://sonarqube.com/api/badges/gate?key=topgearapi)](https://sonarcloud.io/dashboard?id=topgearapi)
[![Waffle.io - Columns and their card count](https://badge.waffle.io/cayodonatti/TopGearApi.svg?columns=all)](http://waffle.io/cayodonatti/TopGearApi)  

Links:  
http://topgearwebsite.azurewebsites.net/  
http://topgearapi.azurewebsites.net/help  

## Integrantes  
Cayo Donatti  
Ricardo Sabaini  

## Minimundo  
TopGear é uma empresa de aluguel de veículos. Para alugar um veículo, o cliente precisa selecionar uma entre as categorias, um modelo específico ou uma faixa de preços, e à partir desse filtro são apresentados os veículos disponíveis, bem como os dados e preços do serviço, que variam de acordo com o preço, luxo e período de aluguel dos modelos de carro. O cliente seleciona um dos veículos disponíveis e determina então o período de aluguel, os serviços extras que deseja (seguro, combustível) e local de retirada/entrega do veículo.  
  
Caso o cliente não tenha cadastro, este deve ser feito, pegando os dados do cliente (Nome, CPF, Email, Endereço e Telefone) e os dados do cartão para pagamento (Número e Código verificador). Deve então ser oferecido ao cliente um serviço de passagens aéreas do parceiro, conforme disponibilidade e período de aluguel do veículo, e levando em conta o local de retirada e endereço do cliente (passagens que vão do endereço do cliente ao local de retirada). Finalizada a reserva, o veículo reservado deve ser retirado da lista de veículos disponíveis.  
  
Na devolução do veículo, deve ser atualizada a localização do veículo. O veículo só deve ser disponibilizado para aluguel no prazo de um dia útil após a devolução, tempo em que ocorrerá a limpeza e reparos neste.  

## Throughtput
[![Throughput Graph](https://graphs.waffle.io/cayodonatti/TopGearApi/throughput.svg)](https://waffle.io/cayodonatti/TopGearApi/metrics/throughput)
