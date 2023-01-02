const lib = require('lib')({token: process.env.STDLIB_SECRET_TOKEN});

await lib.discord.interactions['@1.0.1'].followups.create({
  token: `${context.params.event.token}`,
  content: `<@${context.params.event.member.user.id}> a apăsat pe buton.`
});
await lib.discord.channels['@0.2.2'].messages.update({
  "message_id": `${context.params.event.message.id}`,
  "channel_id": `${context.params.event.channel_id}`,
    "content": "Buton apăsat",
    "tts": false,
    "components": [
      {
        "type": 1,
        "components": [
          {
            "style": 1,
            "label": `BUTON`,
            "custom_id": `cămilă`,
            "disabled": true,
            "type": 2
          }
        ]
      }
    ],
    "embeds": [
      {
        "type": "rich",
        "title": `Apăsați pe buton!`,
        "description": `Cine apasă primul răspunde la întrebare!`,
        "color": 0x00FFFF
      }
    ]
  });
