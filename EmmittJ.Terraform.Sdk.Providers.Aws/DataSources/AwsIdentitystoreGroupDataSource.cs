using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_identitystore_group.
/// </summary>
public class AwsIdentitystoreGroupDataSource : TerraformDataSource
{
    public AwsIdentitystoreGroupDataSource(string name) : base("aws_identitystore_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("display_name");
        this.DeclareOutput("external_ids");
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public string? GroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_id")?.Value;
        set => this.WithProperty("group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    public string? IdentityStoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_store_id")?.Value;
        set => this.WithProperty("identity_store_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The external_ids attribute.
    /// </summary>
    public TerraformExpression ExternalIds => this["external_ids"];

}
