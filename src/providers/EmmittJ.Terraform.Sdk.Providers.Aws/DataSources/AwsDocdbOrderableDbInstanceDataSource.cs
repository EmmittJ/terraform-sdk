using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_docdb_orderable_db_instance Terraform data source.
/// Retrieves information about a aws_docdb_orderable_db_instance.
/// </summary>
public partial class AwsDocdbOrderableDbInstanceDataSource(string name) : TerraformDataSource("aws_docdb_orderable_db_instance", name)
{
    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string>? Engine
    {
        get => new TerraformReference<string>(this, "engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    public TerraformValue<string> InstanceClass
    {
        get => new TerraformReference<string>(this, "instance_class");
        set => SetArgument("instance_class", value);
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformValue<string>? LicenseModel
    {
        get => new TerraformReference<string>(this, "license_model");
        set => SetArgument("license_model", value);
    }

    /// <summary>
    /// The preferred_instance_classes attribute.
    /// </summary>
    public TerraformList<string>? PreferredInstanceClasses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "preferred_instance_classes").ResolveNodes(ctx));
        set => SetArgument("preferred_instance_classes", value);
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
    /// The vpc attribute.
    /// </summary>
    public TerraformValue<bool> Vpc
    {
        get => new TerraformReference<bool>(this, "vpc");
        set => SetArgument("vpc", value);
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformList<string> AvailabilityZones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "availability_zones").ResolveNodes(ctx));
    }

}
