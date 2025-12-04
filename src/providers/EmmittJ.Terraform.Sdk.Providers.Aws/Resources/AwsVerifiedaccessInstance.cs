using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_verifiedaccess_instance Terraform resource.
/// Manages a aws_verifiedaccess_instance resource.
/// </summary>
public partial class AwsVerifiedaccessInstance(string name) : TerraformResource("aws_verifiedaccess_instance", name)
{
    /// <summary>
    /// The cidr_endpoints_custom_subdomain attribute.
    /// </summary>
    public TerraformValue<string>? CidrEndpointsCustomSubdomain
    {
        get => GetArgument<TerraformValue<string>>("cidr_endpoints_custom_subdomain");
        set => SetArgument("cidr_endpoints_custom_subdomain", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? FipsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("fips_enabled");
        set => SetArgument("fips_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
        => AsReference("creation_time");

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedTime
        => AsReference("last_updated_time");

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    public TerraformSet<string> NameServers
        => AsReference("name_servers");

    /// <summary>
    /// The verified_access_trust_providers attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VerifiedAccessTrustProviders
        => AsReference("verified_access_trust_providers");

}
