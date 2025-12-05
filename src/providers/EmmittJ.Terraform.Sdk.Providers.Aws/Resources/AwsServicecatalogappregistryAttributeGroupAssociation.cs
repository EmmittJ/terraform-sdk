using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_servicecatalogappregistry_attribute_group_association Terraform resource.
/// Manages a aws_servicecatalogappregistry_attribute_group_association resource.
/// </summary>
public partial class AwsServicecatalogappregistryAttributeGroupAssociation(string name) : TerraformResource("aws_servicecatalogappregistry_attribute_group_association", name)
{
    /// <summary>
    /// ID of the application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// ID of the attribute group to associate with the application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttributeGroupId is required")]
    public required TerraformValue<string> AttributeGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("attribute_group_id");
        set => SetArgument("attribute_group_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

}
