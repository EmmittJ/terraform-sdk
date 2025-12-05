using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_outposts_assets Terraform data source.
/// Retrieves information about a aws_outposts_assets.
/// </summary>
public partial class AwsOutpostsAssetsDataSource(string name) : TerraformDataSource("aws_outposts_assets", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetRequiredArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The host_id_filter attribute.
    /// </summary>
    public TerraformSet<string>? HostIdFilter
    {
        get => GetArgument<TerraformSet<string>>("host_id_filter");
        set => SetArgument("host_id_filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The status_id_filter attribute.
    /// </summary>
    public TerraformSet<string>? StatusIdFilter
    {
        get => GetArgument<TerraformSet<string>>("status_id_filter");
        set => SetArgument("status_id_filter", value);
    }

    /// <summary>
    /// The asset_ids attribute.
    /// </summary>
    public TerraformList<string> AssetIds
        => CreateReference("asset_ids");

}
