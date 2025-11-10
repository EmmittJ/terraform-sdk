using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_identitystore_groups.
/// </summary>
public class AwsIdentitystoreGroupsDataSource : TerraformDataSource
{
    public AwsIdentitystoreGroupsDataSource(string name) : base("aws_identitystore_groups", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("groups");
        SetOutput("identity_store_id");
        SetOutput("region");
    }

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    public required TerraformProperty<string> IdentityStoreId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_store_id");
        set => SetProperty("identity_store_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The groups attribute.
    /// </summary>
    public TerraformExpression Groups => this["groups"];

}
