using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_synthetics_runtime_versions Terraform data source.
/// Retrieves information about a aws_synthetics_runtime_versions.
/// </summary>
public partial class AwsSyntheticsRuntimeVersionsDataSource(string name) : TerraformDataSource("aws_synthetics_runtime_versions", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
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
    /// The runtime_versions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RuntimeVersions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "runtime_versions").ResolveNodes(ctx));
    }

}
