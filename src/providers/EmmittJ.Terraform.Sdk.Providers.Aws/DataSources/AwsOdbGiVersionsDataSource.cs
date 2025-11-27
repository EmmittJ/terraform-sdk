using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_odb_gi_versions Terraform data source.
/// Retrieves information about a aws_odb_gi_versions.
/// </summary>
public partial class AwsOdbGiVersionsDataSource(string name) : TerraformDataSource("aws_odb_gi_versions", name)
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
    /// The system shape.
    /// </summary>
    public TerraformValue<string>? Shape
    {
        get => new TerraformReference<string>(this, "shape");
        set => SetArgument("shape", value);
    }

    /// <summary>
    /// Information about a specific version of Oracle Grid Infrastructure (GI) software that can be installed on a VM cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> GiVersions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "gi_versions").ResolveNodes(ctx));
    }

}
