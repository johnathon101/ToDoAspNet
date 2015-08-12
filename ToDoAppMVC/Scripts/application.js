
	$(function(){
		$('.todo-title').on('click', function(){
			var uri = "/ToDoItems/_Details/" + $(this).data('id');
			$.get(uri, function(data){
				$('#InfoBlock').html(data);
			});
		});

	});
