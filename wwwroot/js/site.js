
// function cloneRow() {

//     $("#table").on('click', 'input.addButton', function () {
//         var $tr = $(this).closest('tr');
//         var allTrs = $tr.closest('table').find('tr');
//         var lastTr = allTrs[allTrs.length - 1];
//         var $clone = $(lastTr).clone();
//         $clone.find('td').each(function () {
//             var el = $(this).find(':first-child');
//             var id = el.attr('id') || null;
//             let prefix;
//             console.log(id);
//             if (id) {


//                 if (/\d+/.test(id)) {
//                     i = +id.match(/\d/)[0]; //id.substr(id.length - 1);
//                     prefix = id.match(/\d/).input; //id.substr(0, (id.length - 1));
//                     el.attr('id', prefix + (+i + 1));
//                     el.attr('name', prefix + (+i + 1));

//                 } else {
//                     i = id.substr(id.length - 1);
//                     //prefix = id.substr(0, (id.length - 1));
//                     el.attr('id', prefix + (+i + 1));
//                     el.attr('name', `Claims[${ +i + 1}].Value`);

//                 }
//                 console.log(i, prefix);
//                 //el.attr('id', prefix + (+i + 1));
//                 //el.attr('name', prefix + (+i + 1));
//             }
//         });
//         $clone.find('input:text').val('');
//         $tr.closest('table').append($clone);
//     });

//     $("#table").on('change', 'select', function () {
//         var val = $(this).val();
//         $(this).closest('tr').find('input:text').val(val);
//     });
// }
// function cloneRow2() {
//     var $tableBody = $('#table').find("tbody"),
//         $trLast = $tableBody.find("tr:last"),
//         $trNew = $trLast.clone();
//     console.log($trNew.val);


//     $trLast.after($trNew);

// }
function addRow() {

    var id = parseInt($('#table tr:last').attr('data-id'));
    $("#table").append(`
      <tr data-id="${id + 1}">
        <td>
        <input type="text" class="form-control"  name="Claims[${id + 1}].Type"  placeholder="Claim Type" />
</td>
<td>
        <input type="text" class="form-control"  name="Claims[${id + 1}].Value"  placeholder="Claim Value" />
       
</td>
<td> <a href="javascript:void(0);" class="btn btn-danger">Remove</a></td>
</tr>`);

}
$(document).ready(function () {

    $(".addClaim").click(function () {
        addRow();
    });
    $("#claims").on('click', '.remCF', function () {
        $(this).parent().parent().remove();
    });
});