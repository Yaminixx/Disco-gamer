// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Input;
using osu.Game.Beatmaps;
using osu.Game.Input.Handlers;
using osu.Game.Replays;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Objects.Drawables;
using osu.Game.Rulesets.Disco.Objects;
using osu.Game.Rulesets.Disco.Objects.Drawables;
using osu.Game.Rulesets.Disco.Replays;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Disco.UI
{
    [Cached]
    public partial class DrawableDiscoRuleset : DrawableRuleset<DiscoHitObject>
    {
        public DrawableDiscoRuleset(DiscoRuleset ruleset, IBeatmap beatmap, IReadOnlyList<Mod> mods = null)
            : base(ruleset, beatmap, mods)
        {
        }

        public override PlayfieldAdjustmentContainer CreatePlayfieldAdjustmentContainer() => new DiscoPlayfieldAdjustmentContainer();

        protected override Playfield CreatePlayfield() => new DiscoPlayfield();

        protected override ReplayInputHandler CreateReplayInputHandler(Replay replay) => new DiscoFramedReplayInputHandler(replay);

        public override DrawableHitObject<DiscoHitObject> CreateDrawableRepresentation(DiscoHitObject h) => new DrawableDiscoHitObject(h);

        protected override PassThroughInputManager CreateInputManager() => new DiscoInputManager(Ruleset?.RulesetInfo);
    }
}
