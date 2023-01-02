// authenticates you with the API standard library
// type `await lib.` to display API autocomplete
const lib = require('lib')({token: process.env.STDLIB_SECRET_TOKEN});

lib.discord.users['@0.2.1'].me.status.update({
  activity_name: `Ce Spun Românii`,
  activity_type: 'GAME',
  status: 'ONLINE'
});
