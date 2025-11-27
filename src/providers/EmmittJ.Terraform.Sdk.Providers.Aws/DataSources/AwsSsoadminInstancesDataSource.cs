using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ssoadmin_instances Terraform data source.
/// Retrieves information about a aws_ssoadmin_instances.
/// </summary>
public partial class AwsSsoadminInstancesDataSource(string name) : TerraformDataSource("aws_ssoadmin_instances", name)
{
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
    /// The arns attribute.
    /// </summary>
    public TerraformList<string> Arns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The identity_store_ids attribute.
    /// </summary>
    public TerraformList<string> IdentityStoreIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "identity_store_ids").ResolveNodes(ctx));
    }

}
