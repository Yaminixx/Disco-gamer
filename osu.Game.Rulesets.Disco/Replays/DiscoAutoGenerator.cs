// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Beatmaps;
using osu.Game.Rulesets.Disco.Objects;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.Disco.Replays
{
    public class DiscoAutoGenerator : AutoGenerator<DiscoReplayFrame>
    {
        public new Beatmap<DiscoHitObject> Beatmap => (Beatmap<DiscoHitObject>)base.Beatmap;

        public DiscoAutoGenerator(IBeatmap beatmap)
            : base(beatmap)
        {
        }

        protected override void GenerateFrames()
        {
            Frames.Add(new DiscoReplayFrame());

            foreach (DiscoHitObject hitObject in Beatmap.HitObjects)
            {
                Frames.Add(new DiscoReplayFrame
                {
                    Time = hitObject.StartTime,
                    Position = hitObject.Position,
                });
            }
        }
    }
}
