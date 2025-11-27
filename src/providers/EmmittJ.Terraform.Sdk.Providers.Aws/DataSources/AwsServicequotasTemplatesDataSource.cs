using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_servicequotas_templates Terraform data source.
/// Retrieves information about a aws_servicequotas_templates.
/// </summary>
public partial class AwsServicequotasTemplatesDataSource(string name) : TerraformDataSource("aws_servicequotas_templates", name)
{
    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    public TerraformValue<string>? AwsRegion
    {
        get => new TerraformReference<string>(this, "aws_region");
        set => SetArgument("aws_region", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The templates attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Templates
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "templates").ResolveNodes(ctx));
    }

}
