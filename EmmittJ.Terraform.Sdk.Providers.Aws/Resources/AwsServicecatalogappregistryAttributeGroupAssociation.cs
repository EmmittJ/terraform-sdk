using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_servicecatalogappregistry_attribute_group_association resource.
/// </summary>
public class AwsServicecatalogappregistryAttributeGroupAssociation : TerraformResource
{
    public AwsServicecatalogappregistryAttributeGroupAssociation(string name) : base("aws_servicecatalogappregistry_attribute_group_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// ID of the application.
    /// </summary>
    public string? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id")?.Value;
        set => this.WithProperty("application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// ID of the attribute group to associate with the application.
    /// </summary>
    public string? AttributeGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("attribute_group_id")?.Value;
        set => this.WithProperty("attribute_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
