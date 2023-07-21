# DropShadowCrashDemo

I  found this bug when using [MS Community Toolkit](https://github.com/CommunityToolkit/WindowsCommunityToolkit)'s `AttachedCardShadow` in a UWP and I wanted to share it in case someone have any insights on that.
The issue is when attaching the card shadow to a ListViewItem, after removing that item and then adding a new one the app crashes or doesn't render the shadow at all in the new item. In this demo I added two different ListViews, one uses an `ItemsWrapGrid` and the other uses a Community Toolkit's `StaggeredPanel` as ItemsPanelTemplate. The issue seems to be in the first one, not the StaggeredPanel one.

To make this issue happen:
1. Run the app and make sure all the items loaded shows a drop shadow effect when moving the mouse over them.
2. Click on "Hit me", that will remove the first item and add a new one at the beggining.
3. Now move the mouse over that new item.

Just to be clear: Sometimes the app crash, sometimes the shadow doesn't render, I don't see why the issue alternates between these two behaviors.

**Note:** It's important to note that the ListViews used in this demo has an empty `TransitionCollection`, that's because I need the items not having animations on adding or removing, if you remove the empty `TransitionCollection` the drop shadow behaves as expected.

Issue here: https://github.com/CommunityToolkit/WindowsCommunityToolkit/issues/4755
