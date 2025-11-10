using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_workspacesweb_network_settings resource.
/// </summary>
public class AwsWorkspaceswebNetworkSettings : TerraformResource
{
    public AwsWorkspaceswebNetworkSettings(string name) : base("aws_workspacesweb_network_settings", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    [TerraformPropertyName("security_group_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubnetIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformPropertyName("vpc_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VpcId { get; set; }

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    [TerraformPropertyName("associated_portal_arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AssociatedPortalArns => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "associated_portal_arns");

    /// <summary>
    /// The network_settings_arn attribute.
    /// </summary>
    [TerraformPropertyName("network_settings_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkSettingsArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_settings_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
