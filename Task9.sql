  
/*
Предполагается, что существуют 3 таблицы:
первая - Products - таблица продуктов с ключом ID и названием Title,
вторая - Tags - таблица категорий с ключом ID и названием Title,
третья - ProductTags - таблица пар айдишников продукт-Тег
*/

SELECT 
	[P].[Title] 
	,[T].[Title]
FROM [Products] [P]
LEFT JOIN [ProductsTags] [PT]
ON [P].[ID] = [PT].[ProductID]
LEFT JOIN [Tags] [T]
ON [PT].[TagID] = [T].[ID]
