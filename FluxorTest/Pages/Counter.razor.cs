using Fluxor;
using Microsoft.AspNetCore.Components;
using FluxorTest.Store.CounterUseCase;

namespace FluxorTest.Pages
{
    public partial class Counter
    {
		[Inject]
		private IState<CounterState> CounterState { get; set; }

		[Inject]
		public IDispatcher Dispatcher { get; set; }

		private void IncrementCount()
		{
			var action = new IncrementCounterAction();
			Dispatcher.Dispatch(action);
		}
	}
}
