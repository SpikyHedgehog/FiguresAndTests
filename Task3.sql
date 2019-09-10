/*
Предполагается, что существуют 3 таблицы:
первая - Articles - таблица статей с ключом ID и темой Theme,
вторая - Tags - таблица тегов с ключом ID и названием Title,
третья - ArticleTags - таблица пар айдишников Статья-Тег
*/

SELECT 
	[A].[Theme] 
	,[T].[Title]
FROM [Articles] [A]
LEFT JOIN [ArticleTags] [AT]
ON [A].[ID] = [AT].[ArticleID]
LEFT JOIN [Tags] [T]
ON [AT].[TagID] = [T].[ID]
