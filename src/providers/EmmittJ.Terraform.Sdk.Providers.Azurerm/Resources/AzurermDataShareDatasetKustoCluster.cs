using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDataShareDatasetKustoCluster.
/// Nesting mode: single
/// </summary>
public class AzurermDataShareDatasetKustoClusterTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_data_share_dataset_kusto_cluster Terraform resource.
/// Manages a azurerm_data_share_dataset_kusto_cluster resource.
/// </summary>
public partial class AzurermDataShareDatasetKustoCluster(string name) : TerraformResource("azurerm_data_share_dataset_kusto_cluster", name)
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
    /// The kusto_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoClusterId is required")]
    public required TerraformValue<string> KustoClusterId
    {
        get => GetArgument<TerraformValue<string>>("kusto_cluster_id");
        set => SetArgument("kusto_cluster_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The share_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareId is required")]
    public required TerraformValue<string> ShareId
    {
        get => GetArgument<TerraformValue<string>>("share_id");
        set => SetArgument("share_id", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The kusto_cluster_location attribute.
    /// </summary>
    public TerraformValue<string> KustoClusterLocation
        => AsReference("kusto_cluster_location");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataShareDatasetKustoClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataShareDatasetKustoClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
