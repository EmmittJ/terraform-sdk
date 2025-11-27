using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_identitystore_groups Terraform data source.
/// Retrieves information about a aws_identitystore_groups.
/// </summary>
public partial class AwsIdentitystoreGroupsDataSource(string name) : TerraformDataSource("aws_identitystore_groups", name)
{
    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    public required TerraformValue<string> IdentityStoreId
    {
        get => new TerraformReference<string>(this, "identity_store_id");
        set => SetArgument("identity_store_id", value);
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
    /// The groups attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Groups
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "groups").ResolveNodes(ctx));
    }

}
