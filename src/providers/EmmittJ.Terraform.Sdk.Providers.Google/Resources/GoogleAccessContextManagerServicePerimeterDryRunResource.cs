using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleAccessContextManagerServicePerimeterDryRunResource.
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerServicePerimeterDryRunResourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_access_context_manager_service_perimeter_dry_run_resource Terraform resource.
/// Manages a google_access_context_manager_service_perimeter_dry_run_resource resource.
/// </summary>
public partial class GoogleAccessContextManagerServicePerimeterDryRunResource(string name) : TerraformResource("google_access_context_manager_service_perimeter_dry_run_resource", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the Service Perimeter to add this resource to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PerimeterName is required")]
    public required TerraformValue<string> PerimeterName
    {
        get => GetArgument<TerraformValue<string>>("perimeter_name");
        set => SetArgument("perimeter_name", value);
    }

    /// <summary>
    /// A GCP resource that is inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    public required TerraformValue<string> Resource
    {
        get => GetArgument<TerraformValue<string>>("resource");
        set => SetArgument("resource", value);
    }

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    public TerraformValue<string> AccessPolicyId
        => AsReference("access_policy_id");

    /// <summary>
    /// The perimeter etag is internally used to prevent overwriting the list of perimeter resources on PATCH calls. It is retrieved from the same GET perimeter API call that&#39;s used to get the current list of resources. The resource to add or remove is merged into that list and then this etag is sent with the PATCH call along with the updated resource list.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAccessContextManagerServicePerimeterDryRunResourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAccessContextManagerServicePerimeterDryRunResourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
