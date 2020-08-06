
create table RuleHitCount (
	[Practice] varchar(10) not null,
	[Name] varchar(50) not null,
	[Description] varchar(200) not null,
	[Count] int
)

insert into RuleHitCount select 'L83102001', 'Rule 1', 'A stupendously good rule.', 349
insert into RuleHitCount select 'L83102001', 'Rule 2', 'An even better rule.', 21
insert into RuleHitCount select 'L83102001', 'Rule 3', 'A rule for all occasions.', 1323
insert into RuleHitCount select 'L83102001', 'Rule 4', 'Not another rule. I hate authority.', 812
insert into RuleHitCount select 'L82003001', 'Rule 1', 'A stupendously good rule.', 649
insert into RuleHitCount select 'L82003001', 'Rule 3', 'A rule for all occasions.', 146
insert into RuleHitCount select 'L82003001', 'Rule 5', 'Rule makes me feel safe.', 6
insert into RuleHitCount select 'L83100006', 'Rule 2', 'An even better rule.', 419
insert into RuleHitCount select 'L83100006', 'Rule 4', 'Not another rule. I hate authority.', 1132
insert into RuleHitCount select 'L82003004', 'Rule 3', 'A rule for all occasions.', 70
