
create table RuleHitCount (
	[Name] varchar(50) not null,
	[Description] varchar(200) not null,
	[Count] int
)

insert into RuleHitCount select 'Rule 1', 'A stupendously good rule', 49
