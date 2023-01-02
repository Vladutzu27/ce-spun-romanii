const lib = require('lib')({token: process.env.STDLIB_SECRET_TOKEN});

await lib.discord.channels['@0.0.6'].messages.create({
  channel_id: context.params.event.channel_id,
  content: `<@!${context.params.event.member.user.id}>, această comandă e încă în lucru! `
});
await lib.discord.channels['@0.2.2'].messages.update({
"message_id": `${context.params.event.message.id}`,
"channel_id": `${context.params.event.channel_id}`,
content: `<@!${context.params.event.member.user.id}>, această comandă e încă în trebuci! `
});
// Write some custom code here