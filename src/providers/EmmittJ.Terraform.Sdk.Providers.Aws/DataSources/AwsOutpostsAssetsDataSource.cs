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
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The host_id_filter attribute.
    /// </summary>
    public TerraformSet<string>? HostIdFilter
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "host_id_filter").ResolveNodes(ctx));
        set => SetArgument("host_id_filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The status_id_filter attribute.
    /// </summary>
    public TerraformSet<string>? StatusIdFilter
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "status_id_filter").ResolveNodes(ctx));
        set => SetArgument("status_id_filter", value);
    }

    /// <summary>
    /// The asset_ids attribute.
    /// </summary>
    public TerraformList<string> AssetIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "asset_ids").ResolveNodes(ctx));
    }

}
